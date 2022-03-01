import Cabecalho from "../../components/cabecalho/cabecalho.jsx";
import "../../assets/css/header.css";
import "../../assets/css/reconhecimento.css"
import React, { useRef, useEffect, useState } from "react";
import { height, width } from "@mui/system";


export default function Cadastro() {

    const videoRef = useRef(null);
    const photoRef = useRef(null);

    const [hasPhoto, setHasPhoto] = useState(true);

    const [faceIdSelfie, setFaceIdSelfie] = useState("");
    const [clientId, setClientId] = useState("0edf2a694939d79");

    const getVideo = () => {
        navigator.mediaDevices
            .getUserMedia({
                video: { width: 1920, height: 1080 }
            })
            .then(stream => {
                let video = videoRef.current;
                video.srcObject = stream;
                video.play();
            })
            .catch(erro => {
                console.error(erro);
            })
    }

    async function takePhoto()  {
        const width = 640;
        const height = 480;


        let video = videoRef.current;
        let photo = photoRef.current;

        photo.width = width;
        photo.height = height;

        let ctx = photo.getContext("2d");
        ctx.drawImage(video, 0, 0, width, height);

        console.log(photo.toDataURL());

        uploadImage(photo.toDataURL());

        detectarface("https://pbs.twimg.com/media/Ek-OKPOXYAQ0nAy?format=jpg&name=large");
        
        await console.log(faceIdSelfie);

        trocarVideoFoto();
    }

    function closePhoto() {
        let photo = photoRef.current;
        let ctx = photo.getContext("2d");

        ctx.clearRect(0, 0, photo.width, photo.height);

        trocarVideoFoto();
    }

    function trocarVideoFoto() {
        if (hasPhoto) {
            document.getElementById("c-video").style.display = "none";
            document.getElementById("c-foto").style.display = "flex";
            setHasPhoto(false);
        } else {
            document.getElementById("c-foto").style.display = "none";
            document.getElementById("c-video").style.display = "flex";
            setHasPhoto(true);
        }
    }

    function uploadImage(base64Img) {
        var myHeaders = new Headers();
        myHeaders.append("Access-Control-Allow-Origin", "*");

        var formdata = new FormData();
        formdata.append("file", base64Img);
        formdata.append("upload_preset", "j77rjdsg");
        formdata.append("api_key", "153334465432599");

        var requestOptions = {
            method: 'POST',
            headers: myHeaders,
            body: formdata,
            resource_type: "image",
            mode: "cors"
        };

        fetch("https://api.cloudinary.com/v1_1/capigbs/:resource_type/upload", requestOptions)
            .then(response => response.text())
            .then(result => console.log(result))
            .catch(error => console.log('error', error));
    }

    function detectarface(urlImg){
        fetch("https://crachareconhecimento.cognitiveservices.azure.com/face/v1.0/detect?returnFaceId=true",{
            method: 'POST',
            headers:{
                'Content-Type': 'application/json',
                'Ocp-Apim-Subscription-Key': '449e3437fdf34999bc9d6c2ecccc8c2b'
            },
            body: JSON.stringify({url : urlImg})
        })
         .then((resposta) => {
             if (resposta.status === 200) {
                //  console.log(resposta);
                 resposta.json().then((data)=>{
                    //  console.log(data[0].faceId);
                     setFaceIdSelfie(data[0].faceId);
                 })
             }
         })
        
    }

    useEffect(() => {
        getVideo();
    }, [videoRef]);

    return (
        <div>
            <Cabecalho />
            <main className="c-reconhecimento">

                <div id="c-video" className="c-div c-video camera">
                    <video ref={videoRef} ></video>
                    <button onClick={() => takePhoto()}>Tirar foto</button>
                </div>
                <div id="c-foto" className={"result" + (hasPhoto ? "hasPhoto" : "") + " c-div " + "c-foto"}>
                    <canvas ref={photoRef}></canvas>
                    <button onClick={() => closePhoto()}>Fechar</button>
                </div>
            </main>
        </div>
    )
}
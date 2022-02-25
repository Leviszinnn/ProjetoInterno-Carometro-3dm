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
    const [clientId, setClientId] = useState("f4856d7ca783286");

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

    function takePhoto() {
        const width = 640;
        const height = 480;


        let video = videoRef.current;
        let photo = photoRef.current;

        photo.width = width;
        photo.height = height;

        let ctx = photo.getContext("2d");
        ctx.drawImage(video, 0, 0, width, height);

        console.log(photo.toDataURL());

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
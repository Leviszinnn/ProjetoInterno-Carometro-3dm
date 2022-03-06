import Cabecalho from "../../components/cabecalho/cabecalho.jsx"
import "../../assets/css/header.css"
import "../../assets/img/sesi-logo_2.png"
import "../../assets/css/cadastro.css"

export default function cadastro() {
    return (
        <div>
            <Cabecalho />

            <main>
                <section className="container-banner">
                    <section className=" container-fundo container ">
                        <div className=" box-fundo ">
                            <form action="">
                                <div className=" box-banner ">
                                    {/* <img src="./assets/sesi-logo_2.png" alt="logo"> */}
                                        <img src="./src/assets/img/sesi-logo_2.png" alt="logo" />
                                </div>
                                <div className=" espaço-entre">
                                    <div className=" box-inputs ">
                                        <label for=""> </label> <input type=" text " name=" nameJ " placeholder=" Nome: " />
                                    </div>

                                    <div className="box-inputs">
                                        <label for=""></label><input type="text" Serie="serieJ" placeholder="Série:"/>
                                    </div>

                                    <div className="box-inputs">
                                        <label for=""></label><input type="text" turma="turmaJ" placeholder="Turma:"/>
                                    </div>

                                    <div className="box-inputs">
                                        <label for=""></label><input type="text" nasc="nascJ" placeholder="Data nasc:"/>
                                    </div>

                                    <div className="box-inputs">
                                        <label for=""></label><input type="text" RA="RAJ" placeholder="RA:"/>
                                    </div>

                                    <div className="box-inputs">
                                        <label for=""></label><input type="text" cpf="CPFJ" placeholder="CPF:"/>
                                    </div>
                                    <hr/>

                                        <div className="box-linha">

                                            <label for="arquivo">UPLOAD</label>
                                            <input type="file" name="arquivo" id="arquivo"/>

                                        </div>
                                    <hr/>

                                        <button className=" btn-cadastrar "> Cadastro </button>
                                </div>
                            </form>
                        </div>

                    </section>
                </section>
            </main>
        </div>

    )
}
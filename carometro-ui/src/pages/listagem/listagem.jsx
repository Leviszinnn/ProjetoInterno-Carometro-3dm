import Cabecalho from "../../components/cabecalho/cabecalho.jsx"
import "../../assets/css/header.css"
import  "../../assets/css/listagem.css"
import borges from "../../assets/img/Lindao.png"
import lupa from "../../assets/img/search.png"

export default function cadastro() {
    return (
        <div>
            <Cabecalho />

            <main className="main">
                <div className="search_content">
                    <label for="" className="search_label">
                        <input className="search_input" type="search" placeholder="Pesquisar" />
                        <button className="search_btn">
                            <img className="search_img" src={lupa} alt="" />
                        </button>
                    </label>
                </div> 

                <section className="section_teaching-filtered">
                    <div className="content_teaching-filtered">
                        <div className="teaching_filtered">
                            <h1 className="teaching_filtered-title">
                                Filtrar por tipos de ensino:
                            </h1>

                            <label className="teaching_filtered-label" for="">
                                <input type="checkbox" className="input_checkbox" />
                                Ensino Fundamental 1
                            </label>

                            <label className="teaching_filtered-label">
                                <input type="checkbox" />
                                Ensino Fundamental 2
                            </label>
                            <label className="teaching_filtered-label">
                                <input type="checkbox" />
                                Ensino Médio
                            </label>
                        </div>

                        <div className="list-students">
                            <div className="content_card-list">
                                <div className="card_students">
                                    <figure className="card_figure">
                                        <img className="card_img" src={borges} alt="" />
                                    </figure>

                                    <div className="card_content-information">
                                        <h1 className="card_title c-red">Borges</h1>
                                        <div className="card_description-information">
                                            <span>Ensino Fundamental I</span>
                                            <span>Data Nasc:00/00/0000</span>
                                            <span>RA:0000</span>
                                            <span>CPF:00000000000</span>
                                        </div>
                                    </div>
                                </div>


                                <div className="card_students ">
                                    <figure className="card_figure">
                                        <img className="card_img" src={borges} alt="" />
                                    </figure>

                                    <div className="card_content-information">
                                        <h1 className="card_title c-yellow">Borges</h1>
                                        <div className="card_description-information">
                                            <span>Ensino Fundamental II</span>
                                            <span>Data Nasc:00/00/0000</span>
                                            <span>RA:0000</span>
                                            <span>CPF:00000000000</span>
                                        </div>
                                    </div>
                                </div>


                                <div className="card_students ">
                                    <figure className="card_figure">
                                        <img className="card_img" src={borges} alt="" />
                                    </figure>

                                    <div className="card_content-information">
                                        <h1 className="card_title c-green">Borges</h1>
                                        <div className="card_description-information">
                                            <span>Ensino Médio</span>
                                            <span>Data Nasc:00/00/0000</span>
                                            <span>RA:0000</span>
                                            <span>CPF:00000000000</span>
                                        </div>
                                    </div>
                                </div>
                            </div>

                            {/* <!-- section 2 --> */}

                            <div className="content_card-list ">
                                <div className="card_students">
                                    <figure className="card_figure">
                                        <img className="card_img" src={borges} alt="" />
                                    </figure>

                                    <div className="card_content-information">
                                        <h1 className="card_title c-red">Borges</h1>
                                        <div className="card_description-information">
                                            <span>Ensino Fundamental I</span>
                                            <span>Data Nasc:00/00/0000</span>
                                            <span>RA:0000</span>
                                            <span>CPF:00000000000</span>
                                        </div>
                                    </div>
                                </div>


                                <div className="card_students ">
                                    <figure className="card_figure">
                                        <img className="card_img" src={borges} alt="" />
                                    </figure>

                                    <div className="card_content-information">
                                        <h1 className="card_title c-yellow">Borges</h1>
                                        <div className="card_description-information">
                                            <span>Ensino Fundamental II</span>
                                            <span>Data Nasc:00/00/0000</span>
                                            <span>RA:0000</span>
                                            <span>CPF:00000000000</span>
                                        </div>
                                    </div>
                                </div>


                                <div className="card_students">
                                    <figure className="card_figure">
                                        <img className="card_img" src={borges} alt="" />
                                    </figure>

                                    <div className="card_content-information">
                                        <h1 className="card_title c-green">Borges</h1>
                                        <div className="card_description-information">
                                            <span>Ensino Médio</span>
                                            <span>Data Nasc:00/00/0000</span>
                                            <span>RA:0000</span>
                                            <span>CPF:00000000000</span>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </section>
            </main>
        </div>
    )
}
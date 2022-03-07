import React from 'react'
import logo from '../../assets/img/sesi-logo.png'
import { Link } from 'react-router-dom';
import "../../assets/css/header.css"
import { render } from '@testing-library/react';
import '@fontsource/roboto/300.css';
import '@fontsource/roboto/400.css';
import '@fontsource/roboto/500.css';
import '@fontsource/roboto/700.css';
import LogoutIcon from '@mui/icons-material/Logout';


export default function Cabecalho(){

    function sublinharPagina(url) {

        switch (url) {
            case "http://localhost:3000/cadastro":
            
                document.getElementById("cadastroText").setAttribute("class", "menu-header__text--sublinhado")
                break;

            case "http://localhost:3000/reconhecimento":
                document.getElementById("reconhecimentoText").setAttribute("class", "menu-header__text--sublinhado")
                break;

            case "http://localhost:3000/listagem":
                document.getElementById("listagemText").setAttribute("class", "menu-header__text--sublinhado")
                break;
        
            default:
                
                break;
        }

    }
    
    React.useEffect(async () => {
        await sublinharPagina(window.location.href)
    }      
    )

    return(
        <header className="container">
            <div className="c-header">
            <Link className="c-header__logo" to="/listagem"><img className="c-header__logo" src={logo} alt="logo sesi" /></Link>
            <nav className="menu-header">
                <a id="listagemText" className="menu-header__text" href="/listagem">Listagem</a>
                <a id="cadastroText" className="menu-header__text" href="/cadastro">Cadastro</a>
                <a id="reconhecimentoText" className="menu-header__text" href="/reconhecimento">Reconhecimento</a>
            </nav>
            <Link><LogoutIcon sx={{ fontSize: 40 }}/></Link>    
            </div>
        </header>
    )
}
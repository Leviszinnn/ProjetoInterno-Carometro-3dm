import React from 'react'
import logo from '../../assets/img/logoSESI.png'
import { Link } from 'react-router-dom';
import Logout from '@material-ui/icons/ExitToApp';

export default function Cabecalho(){
    return(
        <header className="conteainer c-header">
            <Link to="/"><img className="c-header__logo" src={logo} alt="logo sesi" /></Link>
            <nav className="menu-header">
                <Link className="menu-header__text" to="/">Listagem</Link>
                <Link className="menu-header__text" to="/">Cadastro</Link>
                <Link className="menu-header__text" to="/">Reconhecimento</Link>
            </nav>
            <Logout/>
        </header>
    )
}
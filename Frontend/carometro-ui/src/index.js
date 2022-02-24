import React from 'react';
import ReactDOM from 'react-dom';
import './index.css';
import App from './App';
import reportWebVitals from './reportWebVitals';


import { parseJWT, usuarioAutenticado } from './services/auth';

const routing = (
  <Router>
    <div>
      <Switch>
        {/*
        Troca pelo que a gente fizer
        <Route exact path="/" component={Home} />
        <Route path="/login" component={Login} />
        <Route path="/notFound" component={NotFound} /> 
        <Redirect to="/notFound" /> */}
      </Switch>
    </div>
  </Router>
)

ReactDOM.render(
  routing,
  document.getElementById('root')
);

// If you want to start measuring performance in your app, pass a function
// to log results (for example: reportWebVitals(console.log))
// or send to an analytics endpoint. Learn more: https://bit.ly/CRA-vitals
reportWebVitals();

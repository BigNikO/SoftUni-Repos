import React from 'react';
import ReactDOM from 'react-dom';
import './styles/css/App.css';
import './styles/css/House.css';
import './styles/css/HouseDetails.css';
import './styles/css/Street.css';
import App from './App';

import * as serviceWorker from './serviceWorker';

ReactDOM.render(<App />, document.getElementById('root'));

// If you want your app to work offline and load faster, you can change
// unregister() to register() below. Note this comes with some pitfalls.
// Learn more about service workers: http://bit.ly/CRA-PWA
serviceWorker.unregister();

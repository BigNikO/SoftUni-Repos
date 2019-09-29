import React, { Component } from 'react';
import { BrowserRouter } from 'react-router-dom';
import './App.css';
import './Home.css';
import Layout from './Layout/Layout';

class App extends Component {
  render() {
    return (
      <div className="App">
        <BrowserRouter>
          <Layout />
        </BrowserRouter>
      </div>
    );
  }
}

export default App;

import React, { Component } from 'react';
import './App.css';
import AppHeader from './App/AppHeader';
import AppContent from './App/AppContent';
import AppFooter from './App/AppFooter';

class App extends Component {
  constructor(props) {
    super(props);
    this.state = {
      user: null,
      games: [],
      hasFetched: false,
      loginForm: false,
    };
  }

  registerUser(user) {
    fetch('http://localhost:9999/auth/signup', {
      method: 'POST',
      headers: {
        'Content-Type': 'application/json',
      },
      body: JSON.stringify(user),
    })
      .then(response => response.json())
      .then(body => {
        if (body.errors) {
          console.log(body.errors);
        } else {
          localStorage.setItem('username', body.username);
          localStorage.setItem('userId', body.userId);
          this.setState({ user: body.username });
        }
      });
  }

  loginUser(user) {
    fetch('http://localhost:9999/auth/signin', {
      method: 'POST',
      headers: {
        'Content-Type': 'application/json',
      },
      body: JSON.stringify(user),
    })
      .then(response => response.json())
      .then(body => {
        if (body.errors) {
          console.log(body.errors);
        } else {
          localStorage.setItem('username', body.username);
          localStorage.setItem('userId', body.userId);
          localStorage.setItem('token', body.token);
          this.setState({ user: body.username });
        }
      });
  }

  logout(event) {
    event.preventDefault();
    localStorage.removeItem('username');
    localStorage.removeItem('userId');
    localStorage.removeItem('token');
    this.setState({ user: null });
  }

  componentWillMount() {
    const user = localStorage.getItem('username');
    this.fetchGames();
    user && this.setState({ user });
  }

  createGame(data) {
    fetch('http://localhost:9999/feed/game/create', {
      method: 'POST',
      headers: {
        'Content-Type': 'application/json',
      },
      body: JSON.stringify(data),
    })
      .then(response => response.json())
      .then(body => {
        if (body.errors) {
          console.log(body.errors);
        } else {
          this.fetchGames();
        }
      });
  }

  fetchGames() {
    fetch('http://localhost:9999/feed/games')
      .then(rawData => rawData.json())
      .then(body => this.setState({ games: body.games }));
  }

  switchForm() {
    this.setState({
      loginForm: !this.state.loginForm,
    });
  }

  render() {
    return (
      <main>
        <AppHeader
          user={this.state.user}
          logout={this.logout.bind(this)}
          switchForm={this.switchForm.bind(this)}
          loginForm={this.state.loginForm}
        />
        <AppContent
          registerUser={this.registerUser.bind(this)}
          loginUser={this.loginUser.bind(this)}
          games={this.state.games}
          createGame={this.createGame.bind(this)}
          user={this.state.user}
          loginForm={this.state.loginForm}
        />
        <AppFooter />
      </main>
    );
  }
}

export default App;

import React, { Component } from 'react';
import './Create.css';
import { createMovie } from '../Utils/actions';

class Create extends Component {
  state = {
    title: '',
    storyLine: '',
    trailerUrl: '',
    poster: '',
  };

  onHandleChange = event => {
    const { name, value } = event.target;
    this.setState({ [name]: value });
  };

  onSubmit = e => {
    e.preventDefault();
    createMovie(this.state, localStorage.getItem('token'));
    this.props.history.push('/');
  };

  render() {
    return (
      <div className="Create">
        <h1>Create Movie</h1>
        <form onSubmit={this.onSubmit} onChange={this.onHandleChange}>
          <label htmlFor="title">Title</label>
          <input type="text" id="title" placeholder="Titanic" name="title" />
          <label htmlFor="storyLine">Story Line</label>
          <input
            type="text"
            id="storyLine"
            placeholder="Text"
            name="storyLine"
          />
          <label htmlFor="trailerUrl">Trailer Url</label>
          <input
            type="text"
            id="trailerUrl"
            placeholder="https://www.youtube.com/watch?v=DNyKDI9pn0Q"
            name="trailerUrl"
          />
          <label htmlFor="poster">Movie Poster</label>
          <input
            type="text"
            id="poster"
            placeholder="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSRzg6o0KjhufKFU1iBNr1zuyi0YDNgCUw4Ky5SNATZDVKaIUkiAA"
            name="poster"
          />
          <input type="submit" value="Create" />
        </form>
      </div>
    );
  }
}

export default Create;

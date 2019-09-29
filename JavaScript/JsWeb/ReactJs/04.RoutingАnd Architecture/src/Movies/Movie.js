import React, { Component } from 'react';

class Movie extends Component {
  render() {
    const { movie, onViewStory, onViewTrailer } = this.props;
    const token = localStorage.getItem('token');

    return (
      <li className="movie">
        <h2>{movie.title}</h2>
        <img src={movie.poster} alt={movie.title} />
        {!!token && (
          <span>
            <button
              onClick={() => onViewTrailer(movie.title, movie.trailerUrl)}
            >
              View Trailer
            </button>
            <button onClick={() => onViewStory(movie.title, movie.storyLine)}>
              View Story Line
            </button>
          </span>
        )}
      </li>
    );
  }
}

export default Movie;

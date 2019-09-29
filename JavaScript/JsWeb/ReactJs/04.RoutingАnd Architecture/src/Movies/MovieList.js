import React, { Component } from 'react';
import Movie from './Movie';
import { getMovies } from '../Utils/actions';

class MovieList extends Component {
  state = {
    movies: [],
  };
  async componentDidMount() {
    const movies = await getMovies();
    this.setState({ movies });
  }

  render() {
    const { movies } = this.state;
    const { onViewStory, onViewTrailer } = this.props;

    return (
      movies.length > 0 && (
        <ul className="movies">
          {movies.map((movie, i) => (
            <Movie
              key={i}
              movie={movie}
              onViewStory={onViewStory}
              onViewTrailer={onViewTrailer}
            />
          ))}
        </ul>
      )
    );
  }
}

export default MovieList;

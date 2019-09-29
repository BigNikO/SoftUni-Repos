import React, { Component } from 'react';
import './Home.css';
import MovieList from '../Movies/MovieList';
import { getMovies } from '../Utils/actions';
import StoryLine from '../Movies/StoryLine';
import Trailer from '../Movies/Trailer';

class Home extends Component {
  state = {
    movies: [],
    trailerUrl: null,
    storyLine: null,
    title: null,
    showStory: false,
    showTrailer: false,
  };
  async componentDidMount() {
    const movies = await getMovies();
    this.setState({ movies });
  }

  onViewTrailer = (title, trailerUrl) => {
    this.setState({
      trailerUrl,
      title,
      showTrailer: true,
      showStory: false,
    });
  };

  onViewStory = (title, storyLine) => {
    this.setState({
      storyLine,
      title,
      showStory: true,
      showTrailer: false,
    });
  };

  render() {
    return (
      <div className="Home">
        <h1>All movies</h1>
        {this.state.showTrailer && (
          <Trailer
            trailerUrl={this.state.trailerUrl}
            title={this.state.title}
          />
        )}
        {this.state.showStory && (
          <StoryLine
            storyLine={this.state.storyLine}
            title={this.state.title}
          />
        )}
        <MovieList
          movies={this.state.movies}
          onViewStory={(title, storyLine) => this.onViewStory(title, storyLine)}
          onViewTrailer={(title, trailerUrl) =>
            this.onViewTrailer(title, trailerUrl)
          }
        />
      </div>
    );
  }
}

export default Home;

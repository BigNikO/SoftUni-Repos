import React from 'react';
import fetcher from '../../fetcher';

const IMAGE_URL = `/episodePreview/`;

export default class Slider extends React.Component {
  state = {
    imageUrl: null,
    id: 0,
  };

  componentDidMount() {
    fetcher
      .get(IMAGE_URL + this.state.id)
      .then(data => this.setState({ imageUrl: data.url, id: data.id }));
  }

  onRightClick(id) {
    fetcher
      .get(IMAGE_URL + id)
      .then(data => data && this.setState({ imageUrl: data.url, id: data.id }));
  }

  onLeftClick(id) {
    fetcher
      .get(IMAGE_URL + id)
      .then(data => data && this.setState({ imageUrl: data.url, id: data.id }));
  }
  render = () => {
    const { imageUrl, id } = this.state;

    return (
      <section id="slider">
        <img
          className="button"
          src="/left.png"
          title="previous"
          alt="nav"
          onClick={() => this.onLeftClick(id - 1)}
        />
        <div className="image-container">
          <img src={imageUrl} alt="episode" />
        </div>
        <img
          className="button"
          src="/right.png"
          title="previous"
          alt="nav"
          onClick={() => this.onRightClick(id + 1)}
        />
      </section>
    );
  };
}

import React, { Component } from 'react';

class Trailer extends Component {
  render() {
    const { title, trailerUrl } = this.props;
    return (
      <span>
        <h2>{title}</h2>
        <div className="trailer" style={{ width: '640px', height: '360px' }}>
          <div style={{ width: '100%', height: '100%' }}>
            <iframe
              frameBorder="0"
              allowFullScreen="1"
              allow="accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture"
              title="YouTube video player"
              width="100%"
              height="100%"
              src={trailerUrl}
              id="widget2"
            />
          </div>
        </div>
      </span>
    );
  }
}

export default Trailer;

import React, { Component } from 'react';

class StoryLine extends Component {
  render() {
    const { storyLine, title } = this.props;
    return (
      <span>
        <h2>{title}</h2>
        <p>{storyLine}</p>
      </span>
    );
  }
}

export default StoryLine;

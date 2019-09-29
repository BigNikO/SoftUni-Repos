import React from 'react';

import Rooster from './Rooster';
import Details from './Details';

import fetcher from '../../fetcher';

const rosterUrl = '/roster';

class Characters extends React.Component {
  state = {
    roster: [],
    details: {},
  };

  componentDidMount() {
    fetcher
      .get(rosterUrl)
      .then(roster => {
        return this.setState({ roster, details: roster[0] });
      })
      .catch(err => console.log(err));
  }

  onChose(e) {
    this.setState({ details: e });
  }

  render = () => {
    const { roster, details } = this.state;
    return (
      <div>
        <Rooster roster={roster} onChose={details => this.onChose(details)} />
        <Details details={details} />
      </div>
    );
  };
}

export default Characters;

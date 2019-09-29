import React, { Component } from 'react';
import Streets from './Components/Streets/Streets';
import Houses from './Components/Houses/Houses';
import fetcher from './api/fetcher';
const streetsDataUrl = 'street/all';

class App extends Component {
  state = {
    data: null,
    homes: null,
  };

  componentDidMount() {
    fetcher
      .get(streetsDataUrl)
      .then(data => this.setState({ data, hasFetched: true }));
  }

  render() {
    const { data } = this.state;

    if (!data) {
      return null;
    }

    const defaultHomes = data.streets[0].homes;

    return (
      <div className="App">
        <Streets
          onChooseStreet={homes => this.setState({ homes })}
          streets={data.streets}
        />
        <Houses houses={this.state.homes || defaultHomes} />
      </div>
    );
  }
}

export default App;

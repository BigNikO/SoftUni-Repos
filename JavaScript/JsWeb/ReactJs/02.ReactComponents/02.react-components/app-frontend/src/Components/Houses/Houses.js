import React from 'react';
import House from './House';
import HouseDetails from './HouseDetails';

class Houses extends React.Component {
  state = { house: null };
  render() {
    const { houses } = this.props;
    const { house } = this.state || houses[0];
    return [
      <div className="Houses" key={'houses'}>
        <h2>Houses</h2>
        {houses.map((home, i) => (
          <House
            key={i}
            imageUrl={home.imageUrl}
            onChooseHouse={() => this.setState({ house: home })}
          />
        ))}
      </div>,
      <HouseDetails house={house || houses[0]} key={'house details'} />,
    ];
  }
}

export default Houses;

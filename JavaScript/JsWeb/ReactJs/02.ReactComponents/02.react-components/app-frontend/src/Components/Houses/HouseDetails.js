import React from 'react';

const HouseDetails = props => {
  const { house } = props;
  const { type, imageUrl, description, price } = house || {};
  return (
    <div className="HouseDetails">
      <h2>{type}</h2>
      <div className="image">
        {' '}
        <img src={imageUrl} alt={imageUrl} />
      </div>
      <p>Description: {description}</p>
      <p>Price: {price}</p>
    </div>
  );
};

export default HouseDetails;

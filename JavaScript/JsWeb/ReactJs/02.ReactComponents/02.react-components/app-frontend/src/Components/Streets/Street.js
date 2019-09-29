import React from 'react';

const Street = props => {
  const { location, onChooseStreet, homes } = props;

  return (
    <div className="Street" onMouseEnter={() => onChooseStreet(homes)}>
      <p className="street-info">{location}</p>
    </div>
  );
};

export default Street;

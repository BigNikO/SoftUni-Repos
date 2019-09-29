import React from 'react';

const House = props => (
  <div className="House" onMouseEnter={() => props.onChooseHouse()}>
    <img src={props.imageUrl} alt={props.imageUrl} />
  </div>
);

export default House;

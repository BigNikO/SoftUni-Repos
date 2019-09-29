import React from 'react';
import Street from './Street';

const Streets = props => {
  const { onChooseStreet, streets } = props;
  return (
    <div className="streets">
      <h2>Streets</h2>
      {streets.map(street => (
        <Street
          key={street.location}
          homes={street.homes}
          location={street.location}
          onChooseStreet={onChooseStreet}
          defaultHomes={streets[0]}
        />
      ))}
    </div>
  );
};

export default Streets;

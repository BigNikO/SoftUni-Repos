import React from 'react';

class Rooster extends React.Component {
  render = () => {
    const { roster, onChose } = this.props;
    return (
      <section id="roster">
        {roster.map(details => (
          <img
            src={details.url}
            alt={details.id}
            key={details.id}
            onClick={() => {
              return onChose(details);
            }}
          />
        ))}
      </section>
    );
  };
}

export default Rooster;

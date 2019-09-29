import React from 'react';

class Details extends React.Component {
  render = () => {
    const { details } = this.props;
    const { name, bio, url } = details;

    console.log(details);

    return (
      <section id="bio">
        <div className="image">
          <img src={url} alt={name} />
        </div>
        <div className="info">
          <p>
            Name: {name}
            <strong />
          </p>
          <p>Bio: {bio}</p>
          <p />
        </div>
      </section>
    );
  };
}

export default Details;

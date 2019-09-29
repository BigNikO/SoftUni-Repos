import React from 'react';

const WithWarning = Component => {
  return class extends React.Component {
    render() {
      return (
        <div className="alert">
          <span className="alert-symbol">&#9888;</span>
          <Component {...this.props} />
        </div>
      );
    }
  };
};

export default WithWarning;

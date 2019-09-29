import React from 'react';

const WithError = WrappedComponent => {
  return class extends React.Component {
    state = { hasError: false };

    static getDerivedStateFromError(error) {
      if (error) {
        return { hasError: true };
      }
    }

    render() {
      return !this.state.hasError ? (
        <WrappedComponent {...this.props} />
      ) : (
        <h1>Something went wrong!</h1>
      );
    }
  };
};

export default WithError;

import React, { Component } from 'react';

class BindingForm extends Component {
  handleChange = e => {
    const { name, value } = e.target;
    this.setState({
      [name]: value,
    });
  };
  render() {
    return (
      <div>
        <form
          onChange={this.handleChange}
          onSubmit={e => this.props.onSubmit(e, this.state)}
        >
          <h1>Binding Form</h1>
          {React.Children.map(this.props.children, child => {
            return React.cloneElement(child, {
              ...child.props,
            });
          })}
          <input type="submit" value="Register" />
        </form>
      </div>
    );
  }
}

export default BindingForm;

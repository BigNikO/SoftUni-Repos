import React from 'react';

class CreateForm extends React.Component {
  state = {
    title: null,
    description: null,
    imageUrl: null,
  };

  handleChange = event => {
    const { name, value } = event.target;
    this.setState({ [name]: value });
  };

  render() {
    const { createGame } = this.props;
    return (
      <div className="create-form">
        <h1>Create game</h1>
        <form
          onSubmit={event => {
            event.preventDefault();
            createGame(this.state);
          }}
          onChange={this.handleChange}
        >
          <label>Title</label>
          <input type="text" id="title" name="title" />
          <label>Description</label>
          <textarea type="text" id="description" name="description" />
          <label>ImageUrl</label>
          <input type="text" id="imageUrl" name="imageUrl" />
          <input type="submit" value="Create" />
        </form>
      </div>
    );
  }
}

export default CreateForm;

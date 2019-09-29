function attachEvents() {
  const kinveyAppId = 'kid_ByaBP7cRR';
  const serviceUrl = 'https://baas.kinvey.com/appdata/' + kinveyAppId;
  const kinveyUsername = 'username';
  const kinveyPassword = 'password';
  const base64auth = btoa(kinveyUsername + ':' + kinveyPassword);
  const authHeaders = { Authorization: 'Basic ' + base64auth };
  $('#btnLoadPosts').on('click', loadPosts);
  $('#btnViewPost').on('click', viewPost);
  let postsSection = $('#posts');
  let postBody = $('#post-body');

  function loadPosts() {
    $.ajax({
      url: serviceUrl + '/posts',
      headers: authHeaders,
    })
      .then(success)
      .catch(error);

    function success(posts) {
      postsSection.empty();
      posts.forEach(post => {
        postsSection.append(
          $('<option>')
            .text(post.title)
            .val(post._id)
        );
      });
    }
  }

  function viewPost() {
    let selectedPostId = $('#posts').val();
    let requestPosts = $.ajax({
      url: serviceUrl + '/posts/' + selectedPostId,
      headers: authHeaders,
    });

    let requestComments = $.ajax({
      url: serviceUrl + `/comments/?query={"post_id":"${selectedPostId}"}`,
      headers: authHeaders,
    });

    Promise.all([requestPosts, requestComments])
      .then(displayPostWithComments)
      .catch(error);

    function displayPostWithComments([post, comments]) {
      $('#post-title').text(post.title);
      $('#post-body').text(post.body);
      let postComments = $('#post-comments');
      postComments.empty();
      comments.forEach(comment => {
        postComments.append($('<li>').text(comment.text));
      });
    }
  }

  function error(error) {
    postBody.append($('<div>').text(`Error!`));
  }
}

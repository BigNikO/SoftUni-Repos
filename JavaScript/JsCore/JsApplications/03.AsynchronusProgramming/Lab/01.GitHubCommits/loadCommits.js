function loadCommits() {
  let userName = $('#username').val();
  let repo = $('#repo').val();
  let url = `https://api.github.com/repos/${userName}/${repo}/commits`;

  $('#commits').empty();

  $.get(url)
    .then(displayCommits)
    .catch(displayError);

  function displayCommits(commits) {
    commits.forEach(element =>
      $('#commits').append(
        $('<li>').text(
          `${element.commit.author.name}: ${element.commit.message}`
        )
      )
    );
  }
}

function displayError(error) {
  $('#commits').append(
    $('<li>').text(`Error: ${error.status} (${error.statusText})"`)
  );
}

// async function loadCommits() {
//   try {
//     $('#commits').empty();
//     let username = $('#username').val();
//     let repo = $('#repo').val();
//     let commits = await $.get(
//       `https://api.github.com/repos/${username}/${repo}/commits`
//     );
//     if (!commits) {
//       throw new Error();
//     }
//     commits.forEach(element =>
//       $('#commits').append(
//         $('<li>').text(
//           `${element.commit.author.name}: ${element.commit.message}`
//         )
//       )
//     );
//   } catch (error) {
//     $('#commits').append(
//       $('<li>').text(`Error: ${error.status} (${error.statusText})"`)
//     );
//   }
// }

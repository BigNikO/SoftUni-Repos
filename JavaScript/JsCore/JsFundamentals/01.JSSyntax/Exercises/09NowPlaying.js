function nowPlaying(track) {
  let artist = track[1];
  let song = track[0];
  let time = track[2];
  let nowPlaying = `Now Playing: ${artist} - ${song} [${time}]`;
  console.log(nowPlaying);
}

nowPlaying(['Number One', 'Nelly', '4:09']);

import { fetcher } from './fetcher';

export const registerUser = async data => {
  await fetcher.post('/auth/signup', data);
  await loginUser(data);
};

export const loginUser = async data => {
  const result = await fetcher.post('/auth/signin', data);
  const { token, username, isAdmin } = result;
  localStorage.setItem('username', username);
  localStorage.setItem('token', token);
  localStorage.setItem('isAdmin', isAdmin);
};

export const logoutUser = () => {
  localStorage.removeItem('username');
  localStorage.removeItem('token');
  localStorage.removeItem('isAdmin');
};

export const createMovie = async (data, token) => {
  const result = await fetcher.post('/feed/movie/create', data);
  return result;
};

export const getMovies = async () => {
  const result = await fetcher('/feed/movies');
  return result.movies;
};

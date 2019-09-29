const baseUrl = 'http://localhost:9999';

const defaultOptions = {
  method: 'GET',
  mode: 'cors',
  headers: {
    'Content-Type': 'application/json; charset=utf-8',
    Accept: 'application/json',
  },
};

const getFetchOptions = (options = {}) => {
  const { currentOption } = options;
  const result = {
    ...defaultOptions,
    ...currentOption,
    headers: {
      ...defaultOptions.headers,
      ...(currentOption && currentOption.headers),
    },
  };

  if (options.token) {
    result.headers.Authorization = `Bearer ${options.token}`;
  }

  return result;
};

const fetcher = async (path, options) => {
  const res = await fetch(baseUrl + path, getFetchOptions(options));
  const error = Object.assign(new Error(res.statusText), {
    response: res,
    responseStatus: res.status,
  });
  try {
    const data = await res.json();
    if (!res.ok) {
      error.responseError = data.error;
      throw error;
    }
    return data;
  } catch (_) {
    throw error;
  }
};

['get', 'delete'].forEach(method => {
  fetcher[method] = (path, options) =>
    fetcher(path, {
      currentOption: {
        method: method.toUpperCase(),
        ...(options && options.currentOption),
      },
      ...options,
    });
});

['post', 'put', 'patch'].forEach(method => {
  fetcher[method] = (path, data, options) =>
    fetcher(path, {
      currentOption: {
        method: method.toUpperCase(),
        body: data ? JSON.stringify(data) : '',
        ...(options && options.currentOption),
      },
      ...options,
    });
});

export { fetcher, baseUrl };

function validateRequest(requestHeader) {
  const validMedhods = ['GET', 'POST', 'DELETE', 'CONNECT'];
  const validVersions = ['HTTP/0.9', 'HTTP/1.0', 'HTTP/1.1', 'HTTP/2.0'];
  const urlRegex = /^[\w.]+$/;
  const messageRegex = /^[^<>\\&'"]*$/;

  if (
    !requestHeader.hasOwnProperty('method') ||
    !validMedhods.includes(requestHeader.method)
  ) {
    throw new Error('Invalid request header: Invalid Method');
  }

  if (
    !requestHeader.hasOwnProperty('uri') ||
    !urlRegex.test(requestHeader.uri)
  ) {
    throw new Error('Invalid request header: Invalid URI');
  }

  if (
    !requestHeader.hasOwnProperty('version') ||
    !validVersions.includes(requestHeader.version)
  ) {
    throw new Error('Invalid request header: Invalid Version');
  }

  if (
    !requestHeader.hasOwnProperty('message') ||
    !messageRegex.test(requestHeader.message)
  ) {
    throw new Error('Invalid request header: Invalid Message');
  }

  return requestHeader;
}

console.log(
  validateRequest({
    method: 'GET',
    uri: 'git.master',
    version: 'HTTP/1.1',
    message: '-recursive',
  })
);

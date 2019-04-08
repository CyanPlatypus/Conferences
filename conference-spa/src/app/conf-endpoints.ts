export const DOMAIN = 'http://localhost:5000/api';

const AUTH_ENDPOINT = DOMAIN + 'auth';
export const SIGNIN_ENDPOINT = AUTH_ENDPOINT + '/signin';
export const SIGNUP_ENDPOINT = AUTH_ENDPOINT + '/signup';

export const CONFERENCES_ENDPOINT = DOMAIN + '/conferences';
export const LECTURES_ENDPOINT = DOMAIN + '/lectures';
export const SECTIONS_ENDPOINT = DOMAIN + '/section'
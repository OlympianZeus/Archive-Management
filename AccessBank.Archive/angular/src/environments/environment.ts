import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'Archive',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44334/',
    redirectUri: baseUrl,
    clientId: 'Archive_App',
    responseType: 'code',
    scope: 'offline_access Archive',
    requireHttps: true,
  },
  apis: {
    default: {
      url: 'https://localhost:44334',
      rootNamespace: 'AccessBank.Archive',
    },
  },
} as Environment;

import { RoutesService, eLayoutType } from '@abp/ng.core';
import { APP_INITIALIZER } from '@angular/core';

export const APP_ROUTE_PROVIDER = [
  { provide: APP_INITIALIZER, useFactory: configureRoutes, deps: [RoutesService], multi: true },
];

function configureRoutes(routesService: RoutesService) {
  return () => {
    routesService.add([
      {
        path: '/',
        name: '::Menu:Home',
        iconClass: 'fas fa-home',
        order: 1,
        layout: eLayoutType.application,
      },
      {
        path: '/archive',
        name: '::Menu:Archive',
        iconClass: 'fas fa-file',
        order: 2,
        layout: eLayoutType.application,
      },
      {
        path: '/customers',
        name: '::Menu:Customers',
        parentName: '::Menu:Archive',
        layout: eLayoutType.application
      },
      {
        path:'/correspondances',
        name:'::Menu:Correspondance',
        parentName: '::Menu:Archive',
        layout:eLayoutType.application
      }

    ]);
  };
}

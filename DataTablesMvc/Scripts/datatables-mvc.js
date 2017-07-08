/*!
 * datatables-mvc 1.0
 * http://datatablesmvc.com
 *
 * Author: Miroslaw Slanda
 * Copyright: 2017, Miroslaw Slanda
 */

if (typeof jQuery === 'undefined')
    throw new Error('DataTableMvc requires jQuery');
if (typeof DataTable === 'undefined')
    throw new Error('DataTableMvc requires DataTable');

jQuery.fn.DataTableMvc = function (settings) {
    "use strict";

    var self = jQuery(this);
    self.ready(function () {

        if (typeof settings.events !== 'undefined') {
            if (typeof settings.events.preInit !== 'undefined')
                self.on('init.dt', settings.events.preInit);
            if (typeof settings.events.createdRow !== 'undefined')
                settings.createdRow = settings.events.createdRow;
        }

        self.fnServerParams = settings.fnServerParams;
        settings.fnServerParams = function (data) {
            if (typeof self.fnServerParams === "function") {
                self.fnServerParams(data);
            }
        }

        var dt = self.DataTable(settings);
        if (typeof settings.toolbar !== 'undefined') {
            jQuery('.dataTables_toolbar', self).html(settings.toolbar);
        }

        if (typeof settings.events !== 'undefined') {
            if (typeof settings.events.columnSizing !== 'undefined')
                dt.on('column-sizing.dt', settings.events.columnSizing);
            if (typeof settings.events.columnVisibility !== 'undefined')
                dt.on('column-visibility.dt', settings.events.columnVisibility);
            if (typeof settings.events.destroy !== 'undefined')
                dt.on('destroy.dt', settings.events.destroy);
            if (typeof settings.events.draw !== 'undefined')
                dt.on('draw.dt', settings.events.draw);
            if (typeof settings.events.error !== 'undefined')
                dt.on('error.dt', settings.events.error);
            if (typeof settings.events.init !== 'undefined')
                dt.on('init.dt', settings.events.init);           
            if (typeof settings.events.length !== 'undefined')
                dt.on('length.dt', settings.events.length);
            if (typeof settings.events.order !== 'undefined')
                dt.on('order.dt', settings.events.order);
            if (typeof settings.events.page !== 'undefined')
                dt.on('page.dt', settings.events.page);
            if (typeof settings.events.processing !== 'undefined')
                dt.on('processing.dt', settings.events.processing);
            if (typeof settings.events.search !== 'undefined')
                dt.on('search.dt', settings.events.search);
            if (typeof settings.events.stateLoaded !== 'undefined')
                dt.on('stateLoaded.dt', settings.events.stateLoaded);
            if (typeof settings.events.stateLoadParams !== 'undefined')
                dt.on('stateLoadParams.dt', settings.events.stateLoadParams);
            if (typeof settings.events.stateSaveParams !== 'undefined')
                dt.on('stateSaveParams.dt', settings.events.stateSaveParams);
            if (typeof settings.events.xhr !== 'undefined')
                dt.on('xhr.dt', settings.events.xhr);
        }
    });
}
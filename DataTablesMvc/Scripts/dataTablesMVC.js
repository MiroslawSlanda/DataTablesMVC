$.fn.DataTableMvc = function (settings) {
    "use strict";

    var self = $(this);
    var _settings = settings;   

    self.ready(function () {

        if (typeof _settings.events.preInit !== 'undefined') {
            self.on('preInit.dt', _settings.events.preInit);
        }

        self.fnServerParams = settings.fnServerParams;
        settings.fnServerParams = function (data) {
            if (typeof self.fnServerParams === "function") {
                self.fnServerParams(data);
            }
        }

        var dt = $(self).find('table').DataTable(settings);
        if (typeof _settings.toolbar !== 'undefined') {
            $('.dataTables_toolbar', self).html(_settings.toolbar);
        }

        if (typeof _settings.events.init !== 'undefined') {
            self.on('init.dt', _settings.events.init);
        }

        if (typeof _settings.events.draw !== 'undefined') {
            self.on('draw.dt', _settings.events.draw);
        }

        if (typeof _settings.events.length !== 'undefined') {
            self.on('draw.dt', _settings.events.length);
        }

        if (typeof _settings.events.processing !== 'undefined') {
            self.on('draw.dt', _settings.events.processing);
        }

        if (typeof _settings.events.stateLoaded !== 'undefined') {
            self.on('draw.dt', _settings.events.stateLoaded);
        }

        if (typeof _settings.events.xhr !== 'undefined') {
            self.on('draw.dt', _settings.events.xhr);
        }

        if (typeof _settings.events.rowReorder !== 'undefined') {
            self.on('draw.dt', _settings.events.rowReorder);
        }

        if (typeof _settings.events.rowReorder !== 'undefined') {
            self.on('row-reorder', _settings.events.rowReorder);
        }

        if (typeof _settings.events.rowReordered !== 'undefined') {
            self.on('row-reordered', _settings.events.rowReordered);
        }
    });
}
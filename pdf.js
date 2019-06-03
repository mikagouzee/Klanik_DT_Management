//from https://stackoverflow.com/questions/39364687/export-html-to-pdf-in-asp-net-core
//https://github.com/jsreport/jsreport-core
var path = require('path');

module.exports = function (callback, html) {
    var jsreport = require('jsreport-core')(
        {
            "extensions": {
                "electron-pdf": {
                    "timeout": 20000,
                    "allowLocalFilesAccess": true,
                    "strategy": "electron-ipc"
                }
            }
        });

    jsreport.init().then(function () {
        return jsreport.render({
            template: {
                content: html,
                engine: 'jsrender',
                recipe: 'electron-pdf',
                electron: {
                    marginsType: 1,
                    format:'A4'
                }
            }
            
        }).then(function (resp) {
            callback(/* error */ null, resp.content.toJSON().data);
        });
    }).catch(function (e) {
        callback(/* error */ e, null);
    });
};
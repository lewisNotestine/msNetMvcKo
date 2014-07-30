var self = this;
var barfViewModel = {
    barfWords: ko.observableArray([]),
    
}

var getBarfWords = function () {
    $.get({
        url: '/Barf/Barf',
        success: function (result) {
            self.barfWords(result);
        }
    });
}

$(document).ready(function () {
    ko.applyBindings(barfViewModel, document.rootElement);
    
    
});
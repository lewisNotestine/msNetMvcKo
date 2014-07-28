﻿var Person = {
    PrepareKo: function () {
        ko.bindingHandlers.date = {
            init: function (element, valueAccessor, allBindingsAccessor, viewModel) {
                element.onChange = function () {
                    var observable = valueAccessor();
                    observable(new Date(element.value));
                }
            },
            update: function (element, valueAccessor, allBindingsAccessor, viewModel) {
                var observable = valueAccessor();
                var valueUnwrapped = ko.utils.unwrapObservable(observable);
                if ((typeof valueUnwrapped == 'string' || valueUnwrapped instanceof String) &&
                    valueUnwrapped.indexOf('/Date') === 0) {
                    var parsedDate = Person.ParseJsonDate(valueUnwrapped);
                    element.value = parsedDate.getMonth() + 1 + "/" + parsedDate.getDate() + "/" + parsedDate.getFullYear();
                    observable(parsedDate);
                }
            }
        }
    },

    ParseJsonDate: function (jsonDate) {
        return new Date(parseInt(jsonDate.substr(6)));
    },

    BindUiWithViewModel: function (viewModel) {
        ko.applyBindings(viewModel);
    },

    EvaluateJqueryUI: function () {
        $('.dateInput').datepicker();
    },

    RegisterUIEventHandlers: function () {
        $('#Save').click(function (e) {
            if (document.forms[0].checkValidity()) {
                e.preventDefault();

                $.ajax({
                    type: "POST",
                    url: Person.SaveUrl,
                    data: ko.toJSON(Person.ViewModel),
                    contentType: 'application/json',
                    async: true,
                    beforeSend: function () {
                        //display loading page.
                    },
                    success: function (result) {
                        //Handle the response here.
                    },
                    complete: function () {
                        //Hide loading image.
                    },
                    error: function (jqXHR, textStatus, errorThrown) {
                        //Handle error.
                    }
                });
            }
        });
    },
};

$(document).ready(function () {
    Person.PrepareKo();
    Person.BindUiWithViewModel(Person.ViewModel);
    Person.EvaluateJqueryUI();
    Person.RegisterUIEventHandlers();
});
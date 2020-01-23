
//function myViewModel() {
   
//    this.firstWord = ko.observable('hello'),
//        this.secondWord = ko.observable('world'),

//        this.fullSentence = ko.computed(function () {
//            return this.firstWord() + " " + this.secondWord();
//        }, this);    
//}

// Here's my data model
var myViewModel = function (first, second) {
    this.firstWord = ko.observable(first);
    this.secondWord = ko.observable(second);

    this.fullSentence = ko.pureComputed(function () {
        // Knockout tracks dependencies automatically. It knows that fullName depends on firstName and lastName, because these get called when evaluating fullName.
        return this.firstWord() + " " + this.secondWord();
    }, this);
};

ko.applyBindings(new myViewModel("Hello", "World")); // This makes Knockout get to work



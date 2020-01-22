
function myViewModel() {
   
    this.firstWord = ko.observable('hello'),
        this.secondWord = ko.observable('world'),

        this.fullSentence = ko.computed(function () {
            return this.firstWord() + " " + this.secondWord();
        }, this);    
}




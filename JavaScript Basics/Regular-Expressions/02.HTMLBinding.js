/**HTML binding
 Write a function that puts the value of an object into the content/attributes of HTML tags.
 Add the function to the String.prototype*/
console.log('TASK 2');

String.prototype.bind=function(object){
    var self=this;
    var result=self.match(/data\-bind\-[A-z]*="[A-z]*"/g);
    for(var item in result){
        if(result[item]==='data-bind-content="name"'){
            self=self.replace('><','>'+object['name']+'<');
        }
        else if(result[item]==='data-bind-class="name"'){
            self=self.replace('">','" class="' +object['name'] +'">');
        }
        else if(result[item]==='data-bind-href="link"'){
            self=self.replace('">','" href="' +object['link'] +'">');
        }
        else{
            throw new Error('unknown binding attribute. Add it to the code');
        }
    }
    return self;

}

var str = '<a data-bind-content="name" data-bind-href="link" data-bind-class="name"></a>';

str=str.bind({name: 'Elena', link: 'http://telerikacademy.com'});
console.log(str);
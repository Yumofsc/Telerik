/**Write a JavaScript function that replaces in a HTML document given as string all the tags
 *  <a href="…">…</a> with corresponding tags [URL=…]…/URL].*/
console.log('TASK 08');

var text = '<p>Please visit <a href="http://academy.telerik.com">our site</a> to choose a training course. ' +
    'Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>';

function replaceTags(text){
    return text.replace(/<a href="([^"]+)">([^<]+)<\/a>/gi, '[URL=$1]$2[/URL]');
}

console.log(replaceTags(text));
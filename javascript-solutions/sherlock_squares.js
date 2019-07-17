function squares(a, b){
    let first = Math.ceil(Math.sqrt(a));
    let last = Math.floor(Math.sqrt(b));
    let count = 0;

    if(first > last) return count;

    for(let i = first; i <= last; i++){
        console.log(i ** 2);
        count++;
    }
    return count;
}
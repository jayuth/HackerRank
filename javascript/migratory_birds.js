function migratoryBirds(arr){
    let counter = {};
    let max = 0;
    let common = 0;

    for(let i = 0; i < arr.length; i++){
        let bird = arr[i];
        counter[bird] ? counter[bird] += 1 : counter[bird] = 1;
    }

    console.log(counter);

    for(let key in counter){
        if (counter[key] > max){
            max = counter[key];
            common = key;
        }
    }

    return common;
}
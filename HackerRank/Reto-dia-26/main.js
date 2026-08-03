function processData(input) {
    const tokens = input.trim().split(/\s+/).map(Number);
    
    const [d1, m1, y1] = tokens.slice(0, 3);
    const [d2, m2, y2] = tokens.slice(3, 6);

    let fine = 0;

    if (y1 > y2) {
        fine = 10000;
    } else if (y1 === y2) {
        if (m1 > m2) {
            fine = 500 * (m1 - m2);
        } else if (m1 === m2 && d1 > d2) {
            fine = 15 * (d1 - d2);
        }
    }

    console.log(fine);
}

process.stdin.resume();
process.stdin.setEncoding("ascii");
let _input = "";
process.stdin.on("data", function (input) {
    _input += input;
});
process.stdin.on("end", function () {
   processData(_input);
});
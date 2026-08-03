function processData(input) {
    const lines = input.trim().split('\n');
    const n = parseInt(lines[0], 10);
    const gmailNames = [];
    const pattern = /@gmail\.com$/;

    for (let i = 1; i <= n; i++) {
        if (!lines[i]) continue;
        const [firstName, emailId] = lines[i].trim().split(/\s+/);
        if (pattern.test(emailId)) {
            gmailNames.push(firstName);
        }
    }

    gmailNames.sort();

    gmailNames.forEach(name => console.log(name));
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
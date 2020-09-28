const questions = [
    "What is your name?",
    "What would you rather be doing?",
    "What is yout preferred programming language?" 
];

const ask = (i = 0) => {
    process.stdout.write('\n\n\n', questions[i]);
    process.stdout.write(' > ');
};

ask();

// const answers = [];

process.stdin.on("data", data => {

    process.stdout.write('\n\n', data.toString().trim(),'\n\n');
    // process.exit();
});
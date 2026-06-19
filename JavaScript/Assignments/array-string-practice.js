// Topic: variables and arrays
const topics = ["HTML5", "CSS3", "JavaScript", "SQL", "CSharp"];
const learner = "Student";

// Topic: string template and basic output
console.log(`${learner} completed practice in ${topics.length} topics.`);

// Topic: array map for transforming data
const topicMessages = topics.map((topic, index) => `${index + 1}. Practiced ${topic}`);
console.log(topicMessages);

// Topic: filter for selecting specific values
const webTopics = topics.filter(topic => topic === "HTML5" || topic === "CSS3" || topic === "JavaScript");
console.log("Web topics:", webTopics);

// Topic: function with condition
function getPracticeStatus(score) {
    if (score >= 80) {
        return "Strong understanding";
    }

    if (score >= 60) {
        return "Good foundation";
    }

    return "Needs more practice";
}

console.log(getPracticeStatus(84));

// Topic: object and destructuring
const progress = {
    completed: 5,
    pending: 0,
    confidence: "improving"
};

const { completed, confidence } = progress;
console.log(`Completed topics: ${completed}, confidence: ${confidence}`);

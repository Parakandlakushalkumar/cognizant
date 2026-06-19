export default function App() {
  const modules = ["HTML5", "CSS3", "JavaScript", "React", "SQL", "C#"];

  return (
    <main className="app-shell">
      <section className="hero">
        <p className="eyebrow">DN5 Upskilling</p>
        <h1>Build, practice, and track your web skills.</h1>
        <p className="intro">
          This React starter is ready for experiments after your HTML, CSS, and JavaScript basics.
        </p>
      </section>

      <section className="module-grid" aria-label="Learning modules">
        {modules.map((moduleName) => (
          <article className="module-card" key={moduleName}>
            <span>{moduleName}</span>
          </article>
        ))}
      </section>
    </main>
  );
}

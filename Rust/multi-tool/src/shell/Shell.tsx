import { useState } from 'preact/hooks';
import { ComponentChildren } from 'preact';
import './Shell.css';

interface ShellProps {
  children?: ComponentChildren;
}

export function Shell({ children }: ShellProps) {
  const [drawerOpen, setDrawerOpen] = useState(false);

  const toggleDrawer = () => {
    setDrawerOpen(!drawerOpen);
  };

  return (
    <div className="app-container">
      <aside className={`sidebar ${drawerOpen ? 'open' : ''}`}>
        <div className="sidebar-header">
          <h1>My App</h1>
          <button onClick={toggleDrawer} className="toggle-drawer">
            {drawerOpen ? '←' : '→'}
          </button>
        </div>
        <nav className="nav">
          <a href="#home">Home</a>
          <a href="#about">About</a>
          <a href="#contact">Contact</a>
        </nav>
      </aside>
      <main className="main-content">{children}</main>
    </div>
  );
}
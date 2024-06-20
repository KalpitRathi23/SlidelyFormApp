// src/index.ts
import express, { Request, Response } from 'express';
import bodyParser from 'body-parser';
import fs from 'fs';

const app = express();
const PORT = 3000;
const dbFile = 'db.json';

app.use(bodyParser.json());

interface Submission {
  name: string;
  email: string;
  phone: string;
  github_link: string;
  stopwatch_time: string;
}

// Ensure the database file exists
if (!fs.existsSync(dbFile)) {
  fs.writeFileSync(dbFile, JSON.stringify([]));
}

// /ping endpoint
app.get('/ping', (req: Request, res: Response) => {
  res.send(true);
});

// /submit endpoint
app.post('/submit', (req: Request, res: Response) => {
  const newSubmission: Submission = req.body;
  const submissions = JSON.parse(fs.readFileSync(dbFile, 'utf8'));
  submissions.push(newSubmission);
  fs.writeFileSync(dbFile, JSON.stringify(submissions, null, 2));
  res.send({ success: true });
});

// /read endpoint
app.get('/read', (req: Request, res: Response) => {
  const submissions = JSON.parse(fs.readFileSync(dbFile, 'utf8'));
  res.send(submissions);
});

app.listen(PORT, () => {
  console.log(`Server is running on http://localhost:${PORT}`);
});

using ProblemAlokacjiZadan;

var (tasks, processors) = TaskAlocationDK.DataGenerator.GenerateData(10, 3);

int populationSize = 100;
int generations = 100;
double mutationRate = 0.01;

var bestChromosome = TaskAlocationDK.EvolutionaryAlgorithm.Run(tasks, processors, populationSize, generations, mutationRate);

TaskAlocationDK.TaskAllocator.AssignTasks(tasks, processors, bestChromosome);

TaskAlocationDK.TaskAllocator.DisplayResults(processors);
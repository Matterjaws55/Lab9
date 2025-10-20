BulletPool holds a queue of bullet objects and PlayerController requests bullets from the pool when firing and then the bullets returns itself to the pool when it hits a target.

ITargetBuilder defines how to build a target, SmallTargetBuilder defines the values, TargetDirector controls the building and TargetSpawner spawns said built targets.

IObserver updates ScoreManager, ISubject sends notifications, ScoreManager is an observer that updates the score when notified, and Target notifies observers when hit
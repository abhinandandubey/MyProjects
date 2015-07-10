#include<stdio.h>
#include<conio.h>
#include<malloc.h>
#include<stdlib.h>
struct node
{
	int data;
	struct node *next;
};
void create(struct node **, int item);
void append(struct node **, struct node *, int item);
void display(struct node *);
void addatbeg(struct node **, int item);

void main()
{
	struct node *root;
	int ans, num;
	root =  NULL;
	ans = 0;
	while(ans!=3)
	{
		system("cls");
		display(root);
		printf("\n\t 1. Create");
		printf("\n\t 2. Append");
		printf("\n\t 3. Exit");
		printf("\n\t 4. Add At begining");
		printf("\n\t Enter Choice : ");
		scanf("%d",&ans);
		switch(ans)
		{
			case 1:
				printf("\n\t Enter Element : ");
				scanf("%d",&num);
				create(&root, num);
				break;
			case 2:
				printf("\n\t Enter Element to Add : ");
				scanf("%d", &num);
				append(&root, root, num);
				break;
			case 3:
				printf("\n");
				getch();
				exit(0);
				break;
			case 4:
				printf("\n\t Enter element to insert : ");
				scanf("%d", &num);
				addatbeg(&root, num);
				break;
		}
	}
}

void create(struct node **q, int num)
{
	struct node *temp;
	if(*q == NULL)
	{
		printf("\n\t Create Function called");
		temp = (struct node *)malloc(sizeof(temp));
		temp->data = num;
		temp->next = NULL;
		*q = temp;
	}
	else
	{
		printf("\n\t List Already Exits !");
	}
}
void append(struct node **s, struct node *q, int num)
{
	if(*s == NULL)
	{
		struct node *root;
		create(&root, num);
	}
	else
	{
	struct node *temp;
	struct node *r;
	temp = q;
	while(temp->next != NULL)
	{
		temp = temp->next;
	}
	r = (struct node *)malloc(sizeof(struct node));
	r->data = num;
	r->next = NULL;
	temp->next = r;
	}
}
void display(struct node *q)
{
	struct node *temp;
	temp = q;
	
	if(q == NULL)
		printf("\n\t List Empty !");
	else
	{
		printf("\n\t LIST :");
		while(temp != NULL)
		{
			printf(" %d ", temp->data);
			temp = temp->next;
		}
	}
}
void addatbeg(struct node **q, int num)
{
	struct node *r;
	r = (struct node *)malloc(sizeof(struct node));
	r->data = num;
	r->next = *q;
	*q = r;
}
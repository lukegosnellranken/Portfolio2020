class Github {
    constructor() {
        this.client_id = '30df7daf54b216ce316c',
        this.client_secret = '504f8fd8008e230935dab6c1a5145955a7fd3d8b'

        this.repos_count = 5;
        this.repos_sort = 'created: asc';
    };

    async getUser(user) {
        const profileResponse = await fetch(`https://api.github.com/users/${user}?client_id=${this.client_id}&client_secret=${this.client_secret}`);
    
        const repoResponse = await fetch(`https://api.github.com/users/${user}/repos?per_page=${this.repos_count}&sort=${this.repos_count}&client_id=${this.client_id}&client_secret=${this.client_secret}`);


        const profile = await profileResponse.json();

        const repos = await repoResponse.json();
    
        return {
          profile,
          repos
        }
    }
}

import { DefaultSession } from 'next-auth'
import React from 'react'


declare module 'next-auth' {
    interface Session {
        user: {
            username: string
        } & DefaultSession['user']
    }

    interface Profile {
        username: string
    }
}


declare module 'next-auth/jwt' {
    interface JWT {
        username: string,
        access_token?: string
    }
}

